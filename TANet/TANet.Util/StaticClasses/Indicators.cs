﻿using System;
using TANet.Contracts.Enums;
using TANet.Contracts.OperationResults.Indicators;
using TANet.Util.StaticClasses.EnumConvertors;
using TicTacTec.TA.Library;

namespace TANet.Util.StaticClasses
{
    public static class Indicators
    {
        #region Default Signal Logics

        static Func<decimal[], decimal[], decimal[], IndicatorSignal> macdDefaultSignalLogic = (outputMacd, outputSignal, outputHistogram) =>
            outputMacd[outputMacd.Length - 1] > 0 ? IndicatorSignal.Buy :
            outputMacd[outputMacd.Length - 1] < 0 ? IndicatorSignal.Sell :
            IndicatorSignal.Stay;

        static Func<decimal[], decimal[], IndicatorSignal> maDefaultSignalLogic = (input, output) =>
            input[input.Length - 1] > output[output.Length - 1] ? IndicatorSignal.Buy :
            input[input.Length - 1] < output[output.Length - 1] ? IndicatorSignal.Sell :
            IndicatorSignal.Stay;

        static Func<decimal[], IndicatorSignal> rsiDefaultSignalLogic = output =>
            output[output.Length - 1] <= 30 ? IndicatorSignal.Buy :
            output[output.Length - 1] >= 70 ? IndicatorSignal.Sell :
            IndicatorSignal.Stay;

        static Func<decimal[], decimal[], IndicatorSignal> stochDefaultSignalLogic = (slowK, slowD) =>
            slowK[slowK.Length - 1] < 20 && slowD[slowD.Length -1] < 20 ? IndicatorSignal.Buy :
            slowK[slowK.Length - 1] > 80 && slowD[slowD.Length - 1] > 80 ? IndicatorSignal.Sell :
            IndicatorSignal.Stay;

        #endregion

        public static MovingAverageResult Ma(decimal[] input, 
            MovingAverageType maType, 
            int period, 
            Func<decimal[], decimal[], IndicatorSignal> maSignalLogic = null)
        {
            try
            {
                double[] output = new double[input.Length];
                var result = Core.MovingAverage(0,
                    input.Length - 1,
                    Array.ConvertAll(input, item => (float)item),
                    period,
                    MovingAverageTypes.ToTaLib(maType),
                    out int outBeginIndex,
                    out int outElementsCount,
                    output);

                if (result == Core.RetCode.Success)
                {
                    var outputDecimal = new decimal[outElementsCount];

                    Array.Reverse(output);
                    Array.ConstrainedCopy(Array.ConvertAll(output, item => (decimal)item), outBeginIndex, outputDecimal, 0, outElementsCount);
                    Array.Reverse(outputDecimal);

                    return new MovingAverageResult
                    {
                        Success = true,
                        IndicatorSignal = maSignalLogic != null ?
                            maSignalLogic.Invoke(input, outputDecimal) : maDefaultSignalLogic.Invoke(input, outputDecimal),
                        Ma = outputDecimal
                    };
                }
                else
                {
                    return new MovingAverageResult
                    {
                        Success = false,
                        IndicatorSignal = IndicatorSignal.Stay,
                        Message = result.ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                return new MovingAverageResult
                {
                    Success = false,
                    IndicatorSignal = IndicatorSignal.Stay,
                    Message = ex.ToString()
                };
            }
        }        

        public static MacdResult MacdExt(decimal[] input, 
            MovingAverageType fastMaType, 
            int fastPeriod, 
            MovingAverageType slowMaType, 
            int slowPeriod, 
            MovingAverageType signalMaType, 
            int signalPeriod, 
            Func<decimal[], decimal[], decimal[], IndicatorSignal> macdExtSignalLogic = null)
        {
            try
            {
                var indicatorSignal = IndicatorSignal.Stay;

                double[] outputMacd = new double[input.Length];
                double[] outputSignal = new double[input.Length];
                double[] outputHistogram = new double[input.Length];
                var result = Core.MacdExt(0,
                    input.Length - 1,
                    Array.ConvertAll(input, item => (float)item),
                    fastPeriod, 
                    MovingAverageTypes.ToTaLib(fastMaType),
                    slowPeriod, 
                    MovingAverageTypes.ToTaLib(slowMaType),
                    signalPeriod, 
                    MovingAverageTypes.ToTaLib(signalMaType),
                    out int outBeginIndex, 
                    out int outElementsCount,
                    outputMacd, 
                    outputSignal, 
                    outputHistogram);

                if (result == Core.RetCode.Success)
                {
                    var outputMacdDecimal = new decimal[outElementsCount];
                    var outputSignalDecimal = new decimal[outElementsCount];
                    var outputHistogramDecimal = new decimal[outElementsCount];

                    Array.Reverse(outputMacd);
                    Array.Reverse(outputSignal);
                    Array.Reverse(outputHistogram);

                    Array.ConstrainedCopy(Array.ConvertAll(outputMacd, item => (decimal)item), outBeginIndex, outputMacdDecimal, 0, outElementsCount);
                    Array.ConstrainedCopy(Array.ConvertAll(outputSignal, item => (decimal)item), outBeginIndex, outputSignalDecimal, 0, outElementsCount);
                    Array.ConstrainedCopy(Array.ConvertAll(outputHistogram, item => (decimal)item), outBeginIndex, outputHistogramDecimal, 0, outElementsCount);

                    Array.Reverse(outputMacdDecimal);
                    Array.Reverse(outputSignalDecimal);
                    Array.Reverse(outputHistogramDecimal);

                    indicatorSignal = macdExtSignalLogic != null ?
                            macdExtSignalLogic.Invoke(outputMacdDecimal, outputSignalDecimal, outputHistogramDecimal) : 
                            macdDefaultSignalLogic.Invoke(outputMacdDecimal, outputSignalDecimal, outputHistogramDecimal);

                    return new MacdResult
                    {
                        Success = true,
                        IndicatorSignal = indicatorSignal,
                        Macd = outputMacdDecimal,
                        Signal = outputSignalDecimal,
                        Histogram = outputHistogramDecimal
                    };
                }
                else
                {
                    return new MacdResult
                    {
                        Success = false,
                        Message = result.ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                return new MacdResult
                {
                    Success = false,
                    Message = ex.ToString()
                };
            }
        }

        public static RsiResult Rsi(decimal[] input, int period, Func<decimal[], IndicatorSignal> rsiSignalLogic = null)
        {
            try
            {
                double[] output = new double[input.Length];
                var result = Core.Rsi(0, 
                    input.Length - 1, 
                    Array.ConvertAll(input, item => (double)item), 
                    period, 
                    out int outBeginIndex,
                    out int outElementsCount,
                    output);             

                if (result == Core.RetCode.Success)
                {
                    var outputDecimal = new decimal[outElementsCount];

                    Array.Reverse(output);
                    Array.ConstrainedCopy(Array.ConvertAll(output, item => (decimal)item), outBeginIndex, outputDecimal, 0, outElementsCount);
                    Array.Reverse(outputDecimal);

                    return new RsiResult
                    {
                        Success = true,
                        IndicatorSignal = rsiSignalLogic != null ? 
                            rsiSignalLogic.Invoke(outputDecimal) : rsiDefaultSignalLogic.Invoke(outputDecimal),
                        Rsi = outputDecimal
                    };
                }
                else
                {
                    return new RsiResult
                    {
                        Success = false,
                        IndicatorSignal = IndicatorSignal.Stay,
                        Message = result.ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                return new RsiResult
                {
                    Success = false,
                    IndicatorSignal = IndicatorSignal.Stay,
                    Message = ex.ToString()
                };
            }
        }

        public static StochasticResult Stochastic(decimal[] inputHigh, 
            decimal[] inputLow, 
            decimal[] inputClose, 
            int fastKPeriod, 
            MovingAverageType slowKMaType, 
            int slowKPeriod, 
            MovingAverageType slowDMaType, 
            int slowDPeriod, 
            Func<decimal[], decimal[], IndicatorSignal> stochSignalLogic = null)
        {            
            try
            {
                var indicatorSignal = IndicatorSignal.Stay;

                double[] outputSlowK = new double[inputHigh.Length];
                double[] outputSlowD = new double[inputHigh.Length];

                var result = Core.Stoch(0, 
                    inputHigh.Length - 1,
                    Array.ConvertAll(inputHigh, item => (double)item),
                    Array.ConvertAll(inputLow, item => (double)item),
                    Array.ConvertAll(inputClose, item => (double)item), 
                    fastKPeriod, 
                    slowKPeriod,
                    MovingAverageTypes.ToTaLib(slowKMaType), 
                    slowDPeriod,
                    MovingAverageTypes.ToTaLib(slowDMaType), 
                    out int outBeginIndex,
                    out int outElementsCount, 
                    outputSlowK, 
                    outputSlowD);

                if (result == Core.RetCode.Success)
                {
                    var outputSlowKDecimal = new decimal[outElementsCount];
                    var outputSlowDDecimal = new decimal[outElementsCount];                    

                    Array.Reverse(outputSlowKDecimal);
                    Array.Reverse(outputSlowDDecimal);                    

                    Array.ConstrainedCopy(Array.ConvertAll(outputSlowK, item => (decimal)item), outBeginIndex, outputSlowKDecimal, 0, outElementsCount);
                    Array.ConstrainedCopy(Array.ConvertAll(outputSlowD, item => (decimal)item), outBeginIndex, outputSlowDDecimal, 0, outElementsCount);                    

                    Array.Reverse(outputSlowKDecimal);
                    Array.Reverse(outputSlowDDecimal);

                    indicatorSignal = stochSignalLogic != null ?
                            stochSignalLogic.Invoke(outputSlowKDecimal, outputSlowDDecimal) :
                            stochDefaultSignalLogic.Invoke(outputSlowKDecimal, outputSlowDDecimal);

                    return new StochasticResult
                    {
                        Success = true,
                        IndicatorSignal = indicatorSignal,
                        SlowK = outputSlowKDecimal,
                        SlowD = outputSlowDDecimal
                    };
                }
                else
                {
                    return new StochasticResult
                    {
                        Success = false,
                        IndicatorSignal = IndicatorSignal.Stay,
                        Message = result.ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                return new StochasticResult
                {
                    Success = false,
                    IndicatorSignal = IndicatorSignal.Stay,
                    Message = ex.ToString()
                };
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using TANet.Contracts.Enums;
using TANet.Contracts.Models;
using TANet.Contracts.OperationResults.Indicators;

namespace TANet.Core
{
    public static class Indicators
    {
        #region Aroon

        public static AroonResult Aroon(decimal[] high, decimal[] low, int period)
        {
            return AROON(high, low, period, null);
        }
        public static AroonResult Aroon(decimal[] high, decimal[] low, int period, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return AROON(high, low, period, signalLogic);
        }
        public static AroonResult Aroon(List<Candle> candles, int period)
        {
            return AROON(candles, period);
        }
        public static AroonResult Aroon(List<Candle> candles, int period, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return AROON(candles, period, signalLogic);
        }

        #endregion

        #region AroonOscillator

        public static AroonOscillatorResult AroonOscillator(decimal[] high, decimal[] low, int period)
        {
            return AROON_OSC(high, low, period, null);
        }
        public static AroonOscillatorResult AroonOscillator(decimal[] high, decimal[] low, int period, Func<decimal[], IndicatorSignal> signalLogic)
        {
            return AROON_OSC(high, low, period, signalLogic);
        }
        public static AroonOscillatorResult AroonOscillator(List<Candle> candles, int period)
        {
            return AROON_OSC(candles, period);
        }
        public static AroonOscillatorResult AroonOscillator(List<Candle> candles, int period, Func<decimal[], IndicatorSignal> signalLogic)
        {
            return AROON_OSC(candles, period, signalLogic);
        }

        #endregion

        #region ATR

        public static AtrResult Atr(decimal[] high, decimal[] low, decimal[] close, int period)
        {
            return ATR(high, low, close, period, null);
        }
        public static AtrResult Atr(decimal[] high, decimal[] low, decimal[] close, int period, Func<decimal[], IndicatorSignal> signalLogic)
        {
            return ATR(high, low, close, period, signalLogic);
        }
        public static AtrResult Atr(List<Candle> candles, int period)
        {
            return ATR(candles, period);
        }
        public static AtrResult Atr(List<Candle> candles, int period, Func<decimal[], IndicatorSignal> signalLogic)
        {
            return ATR(candles, period, signalLogic);
        }

        #endregion

        #region BollingerBands

        public static BollingerBandsResult BollingerBands(decimal[] input, int period, double standardDeviationUp, double standardDeviationDown)
        {
            return B_BANDS(input, period, standardDeviationUp, standardDeviationDown, MovingAverageType.Sma);
        }
        public static BollingerBandsResult BollingerBands(decimal[] input, int period, double standardDeviationUp, double standardDeviationDown, Func<decimal[], decimal[], decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return B_BANDS(input, period, standardDeviationUp, standardDeviationDown, MovingAverageType.Sma, signalLogic: signalLogic);
        }
        public static BollingerBandsResult BollingerBands(decimal[] input, int period, double standardDeviationUp, double standardDeviationDown, MovingAverageType maType)
        {
            return B_BANDS(input, period, standardDeviationUp, standardDeviationDown, maType);
        }
        public static BollingerBandsResult BollingerBands(decimal[] input, int period, double standardDeviationUp, double standardDeviationDown, MovingAverageType maType, Func<decimal[], decimal[], decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return B_BANDS(input, period, standardDeviationUp, standardDeviationDown, maType, signalLogic: signalLogic);
        }
        public static BollingerBandsResult BollingerBands(List<Candle> input, int period, double standardDeviationUp, double standardDeviationDown)
        {
            return B_BANDS(input, period, standardDeviationUp, standardDeviationDown, MovingAverageType.Sma, IndicatorCalculationBase.Close);
        }
        public static BollingerBandsResult BollingerBands(List<Candle> input, int period, double standardDeviationUp, double standardDeviationDown, Func<decimal[], decimal[], decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return B_BANDS(input, period, standardDeviationUp, standardDeviationDown, MovingAverageType.Sma, IndicatorCalculationBase.Close, signalLogic);
        }
        public static BollingerBandsResult BollingerBands(List<Candle> input, int period, double standardDeviationUp, double standardDeviationDown, IndicatorCalculationBase calculationBase)
        {
            return B_BANDS(input, period, standardDeviationUp, standardDeviationDown, MovingAverageType.Sma, calculationBase: calculationBase);
        }
        public static BollingerBandsResult BollingerBands(List<Candle> input, int period, double standardDeviationUp, double standardDeviationDown, IndicatorCalculationBase calculationBase, Func<decimal[], decimal[], decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return B_BANDS(input, period, standardDeviationUp, standardDeviationDown, MovingAverageType.Sma, calculationBase: calculationBase, signalLogic: signalLogic);
        }
        public static BollingerBandsResult BollingerBands(List<Candle> input, int period, double standardDeviationUp, double standardDeviationDown, MovingAverageType maType, IndicatorCalculationBase calculationBase)
        {
            return B_BANDS(input, period, standardDeviationUp, standardDeviationDown, maType, calculationBase: calculationBase);
        }
        public static BollingerBandsResult BollingerBands(List<Candle> input, int period, double standardDeviationUp, double standardDeviationDown, MovingAverageType maType, IndicatorCalculationBase calculationBase, Func<decimal[], decimal[], decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return B_BANDS(input, period, standardDeviationUp, standardDeviationDown, maType, calculationBase: calculationBase, signalLogic: signalLogic);
        }

        #endregion

        #region CCI

        public static CciResult Cci(decimal[] high, decimal[] low, decimal[] close, int period)
        {
            return CCI(high, low, close, period, null);
        }
        public static CciResult Cci(decimal[] high, decimal[] low, decimal[] close, int period, Func<decimal[], IndicatorSignal> signalLogic)
        {
            return CCI(high, low, close, period, signalLogic);
        }
        public static CciResult Cci(List<Candle> candles, int period)
        {
            return CCI(candles, period);
        }
        public static CciResult Cci(List<Candle> candles, int period, Func<decimal[], IndicatorSignal> signalLogic)
        {
            return CCI(candles, period, signalLogic);
        }

        #endregion

        #region EMA

        public static MovingAverageResult Ema(decimal[] input, int period)
        {
            return Indicators.MA(input, MovingAverageType.Ema, period);
        }
        public static MovingAverageResult Ema(decimal[] input, int period, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MA(input, MovingAverageType.Ema, period, signalLogic: signalLogic);
        }
        public static MovingAverageResult Ema(List<Candle> input, int period)
        {
            return Indicators.MA(input, MovingAverageType.Ema, period);
        }
        public static MovingAverageResult Ema(List<Candle> input, int period, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MA(input, MovingAverageType.Ema, period, signalLogic: signalLogic);
        }
        public static MovingAverageResult Ema(List<Candle> input, int period, IndicatorCalculationBase calculationBase)
        {
            return Indicators.MA(input, MovingAverageType.Ema, period, calculationBase: calculationBase);
        }
        public static MovingAverageResult Ema(List<Candle> input, int period, IndicatorCalculationBase calculationBase, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MA(input, MovingAverageType.Ema, period, calculationBase: calculationBase, signalLogic: signalLogic);
        }

        #endregion

        #region ExtendedMacd

        public static MacdResult ExtendedMacd(decimal[] input, MovingAverageType fastMaType, int fastPeriod, MovingAverageType slowMaType, int slowPeriod, MovingAverageType signalMaType, int signalPeriod)
        {
            return Indicators.MACD(input, fastMaType, fastPeriod, slowMaType, slowPeriod, signalMaType, signalPeriod);
        }
        public static MacdResult ExtendedMacd(decimal[] input, MovingAverageType fastMaType, int fastPeriod, MovingAverageType slowMaType, int slowPeriod, MovingAverageType signalMaType, int signalPeriod, Func<decimal[], decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MACD(input, fastMaType, fastPeriod, slowMaType, slowPeriod, signalMaType, signalPeriod, signalLogic: signalLogic);
        }
        public static MacdResult ExtendedMacd(List<Candle> input, MovingAverageType fastMaType, int fastPeriod, MovingAverageType slowMaType, int slowPeriod, MovingAverageType signalMaType, int signalPeriod)
        {
            return Indicators.MACD(input, fastMaType, fastPeriod, slowMaType, slowPeriod, signalMaType, signalPeriod);
        }
        public static MacdResult ExtendedMacd(List<Candle> input, MovingAverageType fastMaType, int fastPeriod, MovingAverageType slowMaType, int slowPeriod, MovingAverageType signalMaType, int signalPeriod, Func<decimal[], decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MACD(input, fastMaType, fastPeriod, slowMaType, slowPeriod, signalMaType, signalPeriod, signalLogic: signalLogic);
        }
        public static MacdResult ExtendedMacd(List<Candle> input, MovingAverageType fastMaType, int fastPeriod, MovingAverageType slowMaType, int slowPeriod, MovingAverageType signalMaType, int signalPeriod, IndicatorCalculationBase calculationBase)
        {
            return Indicators.MACD(input, fastMaType, fastPeriod, slowMaType, slowPeriod, signalMaType, signalPeriod, calculationBase: calculationBase);
        }
        public static MacdResult ExtendedMacd(List<Candle> input, MovingAverageType fastMaType, int fastPeriod, MovingAverageType slowMaType, int slowPeriod, MovingAverageType signalMaType, int signalPeriod, IndicatorCalculationBase calculationBase, Func<decimal[], decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MACD(input, fastMaType, fastPeriod, slowMaType, slowPeriod, signalMaType, signalPeriod, calculationBase: calculationBase, signalLogic: signalLogic);
        }

        #endregion        

        #region KAMA

        public static MovingAverageResult Kama(decimal[] input, int period)
        {
            return Indicators.MA(input, MovingAverageType.Kama, period);
        }
        public static MovingAverageResult Kama(decimal[] input, int period, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MA(input, MovingAverageType.Kama, period, signalLogic: signalLogic);
        }
        public static MovingAverageResult Kama(List<Candle> input, int period)
        {
            return Indicators.MA(input, MovingAverageType.Kama, period);
        }
        public static MovingAverageResult Kama(List<Candle> input, int period, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MA(input, MovingAverageType.Kama, period, signalLogic: signalLogic);
        }
        public static MovingAverageResult Kama(List<Candle> input, int period, IndicatorCalculationBase calculationBase)
        {
            return Indicators.MA(input, MovingAverageType.Kama, period, calculationBase: calculationBase);
        }
        public static MovingAverageResult Kama(List<Candle> input, int period, IndicatorCalculationBase calculationBase, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MA(input, MovingAverageType.Kama, period, calculationBase: calculationBase, signalLogic: signalLogic);
        }

        #endregion

        #region MACD

        public static MacdResult Macd(decimal[] input, int fastPeriod, int slowPeriod, int signalPeriod)
        {
            return Indicators.MACD(input, MovingAverageType.Ema, fastPeriod, MovingAverageType.Ema, slowPeriod, MovingAverageType.Ema, signalPeriod);
        }
        public static MacdResult Macd(decimal[] input, int fastPeriod, int slowPeriod, int signalPeriod, Func<decimal[], decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MACD(input, MovingAverageType.Ema, fastPeriod, MovingAverageType.Ema, slowPeriod, MovingAverageType.Ema, signalPeriod, signalLogic: signalLogic);
        }
        public static MacdResult Macd(List<Candle> input, int fastPeriod, int slowPeriod, int signalPeriod)
        {
            return Indicators.MACD(input, MovingAverageType.Ema, fastPeriod, MovingAverageType.Ema, slowPeriod, MovingAverageType.Ema, signalPeriod);
        }
        public static MacdResult Macd(List<Candle> input, int fastPeriod, int slowPeriod, int signalPeriod, Func<decimal[], decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MACD(input, MovingAverageType.Ema, fastPeriod, MovingAverageType.Ema, slowPeriod, MovingAverageType.Ema, signalPeriod, signalLogic: signalLogic);
        }
        public static MacdResult Macd(List<Candle> input, int fastPeriod, int slowPeriod, int signalPeriod, IndicatorCalculationBase calculationBase)
        {
            return Indicators.MACD(input, MovingAverageType.Ema, fastPeriod, MovingAverageType.Ema, slowPeriod, MovingAverageType.Ema, signalPeriod, calculationBase: calculationBase);
        }
        public static MacdResult Macd(List<Candle> input, int fastPeriod, int slowPeriod, int signalPeriod, IndicatorCalculationBase calculationBase, Func<decimal[], decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MACD(input, MovingAverageType.Ema, fastPeriod, MovingAverageType.Ema, slowPeriod, MovingAverageType.Ema, signalPeriod, calculationBase: calculationBase, signalLogic: signalLogic);
        }

        #endregion

        #region MFI

        public static MfiResult Mfi(decimal[] high, decimal[] low, decimal[] close, decimal[] volume, int period)
        {
            return MFI(high, low, close, volume, period, null);
        }
        public static MfiResult Mfi(decimal[] high, decimal[] low, decimal[] close, decimal[] volume, int period, Func<decimal[], IndicatorSignal> signalLogic)
        {
            return MFI(high, low, close, volume, period, signalLogic);
        }
        public static MfiResult Mfi(List<Candle> candles, int period)
        {
            return MFI(candles, period);
        }
        public static MfiResult Mfi(List<Candle> candles, int period, Func<decimal[], IndicatorSignal> signalLogic)
        {
            return MFI(candles, period, signalLogic);
        }

        #endregion

        #region ParabolicSar

        public static ParabolicSarResult ParabolicSar(decimal[] high, decimal[] low, double acceleration, double maximum)
        {
            return P_SAR(high, low, acceleration, maximum, null);
        }
        public static ParabolicSarResult ParabolicSar(decimal[] high, decimal[] low, double acceleration, double maximum, Func<decimal[], decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return P_SAR(high, low, acceleration, maximum, signalLogic);
        }
        public static ParabolicSarResult ParabolicSar(List<Candle> candles, double acceleration, double maximum)
        {
            return P_SAR(candles, acceleration, maximum);
        }
        public static ParabolicSarResult ParabolicSar(List<Candle> candles, double acceleration, double maximum, Func<decimal[], decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return P_SAR(candles, acceleration, maximum, signalLogic);
        }

        #endregion

        #region RSI

        public static RsiResult Rsi(decimal[] input, int period)
        {
            return RSI(input, period, null);
        }
        public static RsiResult Rsi(decimal[] input, int period, Func<decimal[], IndicatorSignal> signalLogic)
        {
            return RSI(input, period, signalLogic);
        }
        public static RsiResult Rsi(List<Candle> input, int period)
        {
            return RSI(input, period);
        }
        public static RsiResult Rsi(List<Candle> input, int period, IndicatorCalculationBase calculationBase)
        {
            return RSI(input, period, calculationBase: calculationBase);
        }

        #endregion

        #region SMA

        public static MovingAverageResult Sma(decimal[] input, int period)
        {
            return Indicators.MA(input, MovingAverageType.Sma, period);
        }
        public static MovingAverageResult Sma(decimal[] input, int period, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MA(input, MovingAverageType.Sma, period, signalLogic: signalLogic);
        }
        public static MovingAverageResult Sma(List<Candle> input, int period)
        {
            return Indicators.MA(input, MovingAverageType.Sma, period);
        }
        public static MovingAverageResult Sma(List<Candle> input, int period, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MA(input, MovingAverageType.Sma, period, signalLogic: signalLogic);
        }
        public static MovingAverageResult Sma(List<Candle> input, int period, IndicatorCalculationBase calculationBase)
        {
            return Indicators.MA(input, MovingAverageType.Sma, period, calculationBase: calculationBase);
        }
        public static MovingAverageResult Sma(List<Candle> input, int period, IndicatorCalculationBase calculationBase, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MA(input, MovingAverageType.Sma, period, calculationBase: calculationBase, signalLogic: signalLogic);
        }

        #endregion

        #region Stochastic

        public static StochasticResult Stochsatic(List<Candle> candles, int fastKPeriod, int slowKPeriod, int slowDPeriod)
        {
            return STOCH(candles, fastKPeriod, MovingAverageType.Sma, slowKPeriod, MovingAverageType.Sma, slowDPeriod);
        }
        public static StochasticResult Stochsatic(List<Candle> candles, int fastKPeriod, MovingAverageType slowKMaType, int slowKPeriod, MovingAverageType slowDMaType, int slowDPeriod)
        {
            return STOCH(candles, fastKPeriod, slowKMaType, slowKPeriod, slowDMaType, slowDPeriod);
        }
        public static StochasticResult Stochsatic(List<Candle> candles, int fastKPeriod, int slowKPeriod, int slowDPeriod, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return STOCH(candles, fastKPeriod, MovingAverageType.Sma, slowKPeriod, MovingAverageType.Sma, slowDPeriod, signalLogic);
        }
        public static StochasticResult Stochsatic(List<Candle> candles, int fastKPeriod, MovingAverageType slowKMaType, int slowKPeriod, MovingAverageType slowDMaType, int slowDPeriod, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return STOCH(candles, fastKPeriod, slowKMaType, slowKPeriod, slowDMaType, slowDPeriod, signalLogic);
        }
        public static StochasticResult Stochsatic(decimal[] high, decimal[] low, decimal[] close, int fastKPeriod, int slowKPeriod, int slowDPeriod)
        {
            return STOCH(high, low, close, fastKPeriod, MovingAverageType.Sma, slowKPeriod, MovingAverageType.Sma, slowDPeriod);
        }
        public static StochasticResult Stochsatic(decimal[] high, decimal[] low, decimal[] close, int fastKPeriod, MovingAverageType slowKMaType, int slowKPeriod, MovingAverageType slowDMaType, int slowDPeriod)
        {
            return STOCH(high, low, close, fastKPeriod, slowKMaType, slowKPeriod, slowDMaType, slowDPeriod);
        }
        public static StochasticResult Stochsatic(decimal[] high, decimal[] low, decimal[] close, int fastKPeriod, int slowKPeriod, int slowDPeriod, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return STOCH(high, low, close, fastKPeriod, MovingAverageType.Sma, slowKPeriod, MovingAverageType.Sma, slowDPeriod, signalLogic);
        }
        public static StochasticResult Stochsatic(decimal[] high, decimal[] low, decimal[] close, int fastKPeriod, MovingAverageType slowKMaType, int slowKPeriod, MovingAverageType slowDMaType, int slowDPeriod, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return STOCH(high, low, close, fastKPeriod, slowKMaType, slowKPeriod, slowDMaType, slowDPeriod, signalLogic);
        }

        #endregion

        #region TEMA

        public static MovingAverageResult Tema(decimal[] input, int period)
        {
            return Indicators.MA(input, MovingAverageType.Tema, period);
        }
        public static MovingAverageResult Tema(decimal[] input, int period, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MA(input, MovingAverageType.Tema, period, signalLogic: signalLogic);
        }
        public static MovingAverageResult Tema(List<Candle> input, int period)
        {
            return Indicators.MA(input, MovingAverageType.Tema, period);
        }
        public static MovingAverageResult Tema(List<Candle> input, int period, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MA(input, MovingAverageType.Tema, period, signalLogic: signalLogic);
        }
        public static MovingAverageResult Tema(List<Candle> input, int period, IndicatorCalculationBase calculationBase)
        {
            return Indicators.MA(input, MovingAverageType.Tema, period, calculationBase: calculationBase);
        }
        public static MovingAverageResult Tema(List<Candle> input, int period, IndicatorCalculationBase calculationBase, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MA(input, MovingAverageType.Tema, period, calculationBase: calculationBase, signalLogic: signalLogic);
        }

        #endregion

        #region WilliamsR

        public static WilliamsRResult WilliamsR(decimal[] high, decimal[] low, decimal[] close, decimal[] volume, int period)
        {
            return WILL_R(high, low, close, period, null);
        }
        public static WilliamsRResult WilliamsR(decimal[] high, decimal[] low, decimal[] close, decimal[] volume, int period, Func<decimal[], IndicatorSignal> signalLogic)
        {
            return WILL_R(high, low, close, period, signalLogic);
        }
        public static WilliamsRResult WilliamsR(List<Candle> candles, int period)
        {
            return WILL_R(candles, period);
        }
        public static WilliamsRResult WilliamsR(List<Candle> candles, int period, Func<decimal[], IndicatorSignal> signalLogic)
        {
            return WILL_R(candles, period, signalLogic);
        }

        #endregion

        #region WMA

        public static MovingAverageResult Wma(decimal[] input, int period)
        {
            return Indicators.MA(input, MovingAverageType.Wma, period);
        }
        public static MovingAverageResult Wma(decimal[] input, int period, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MA(input, MovingAverageType.Wma, period, signalLogic: signalLogic);
        }
        public static MovingAverageResult Wma(List<Candle> input, int period)
        {
            return Indicators.MA(input, MovingAverageType.Wma, period);
        }
        public static MovingAverageResult Wma(List<Candle> input, int period, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MA(input, MovingAverageType.Wma, period, signalLogic: signalLogic);
        }
        public static MovingAverageResult Wma(List<Candle> input, int period, IndicatorCalculationBase calculationBase)
        {
            return Indicators.MA(input, MovingAverageType.Wma, period, calculationBase: calculationBase);
        }
        public static MovingAverageResult Wma(List<Candle> input, int period, IndicatorCalculationBase calculationBase, Func<decimal[], decimal[], IndicatorSignal> signalLogic)
        {
            return Indicators.MA(input, MovingAverageType.Wma, period, calculationBase: calculationBase, signalLogic: signalLogic);
        }

        #endregion

        #region Private Methods

        /* AROON */

        private static AroonResult AROON(List<Candle> candles,
            int period,
            Func<decimal[], decimal[], IndicatorSignal> signalLogic = null)
        {
            var high = candles.Select(c => c.High).ToArray();
            var low = candles.Select(c => c.Low).ToArray();            

            return AROON(high, low, period, signalLogic);
        }
        private static AroonResult AROON(decimal[] high,
            decimal[] low,            
            int period,
            Func<decimal[], decimal[], IndicatorSignal> signalLogic = null)
        {
            return TANet.Util.StaticClasses.Indicators.Aroon(high, low, period, signalLogic);
        }

        /* AROON_OSC */

        private static AroonOscillatorResult AROON_OSC(List<Candle> candles,
            int period,
            Func<decimal[], IndicatorSignal> signalLogic = null)
        {
            var high = candles.Select(c => c.High).ToArray();
            var low = candles.Select(c => c.Low).ToArray();

            return AROON_OSC(high, low, period, signalLogic);
        }
        private static AroonOscillatorResult AROON_OSC(decimal[] high,
            decimal[] low,
            int period,
            Func<decimal[], IndicatorSignal> signalLogic = null)
        {
            return TANet.Util.StaticClasses.Indicators.AroonOscillator(high, low, period, signalLogic);
        }

        /* ATR */

        private static AtrResult ATR(List<Candle> candles,
            int period,            
            Func<decimal[], IndicatorSignal> signalLogic = null)
        {
            var high = candles.Select(c => c.High).ToArray();
            var low = candles.Select(c => c.Low).ToArray();
            var close = candles.Select(c => c.Close).ToArray();

            return ATR(high, low, close, period, signalLogic);
        }
        private static AtrResult ATR(decimal[] high,
            decimal[] low,
            decimal[] close,
            int period,
            Func<decimal[], IndicatorSignal> signalLogic = null)
        {
            return TANet.Util.StaticClasses.Indicators.Atr(high, low, close, period, signalLogic);
        }

        /* B_BANDS */

        private static BollingerBandsResult B_BANDS(List<Candle> candles,            
            int period,
            double stdDevUp,
            double stdDevDown,
            MovingAverageType maType, 
            IndicatorCalculationBase calculationBase = IndicatorCalculationBase.Close,
            Func<decimal[], decimal[], decimal[], decimal[], IndicatorSignal> signalLogic = null)
        {
            decimal[] input;
            if (calculationBase == IndicatorCalculationBase.Close)
                input = candles.Select(c => c.Close).ToArray();

            else if (calculationBase == IndicatorCalculationBase.Open)
                input = candles.Select(c => c.Open).ToArray();

            else if (calculationBase == IndicatorCalculationBase.High)
                input = candles.Select(c => c.High).ToArray();

            else if (calculationBase == IndicatorCalculationBase.Low)
                input = candles.Select(c => c.Low).ToArray();

            else
                input = candles.Select(c => c.Close).ToArray();

            return B_BANDS(input, period, stdDevUp, stdDevDown, maType, signalLogic);
        }
        private static BollingerBandsResult B_BANDS(decimal[] input,
            int period,
            double stdDevUp,
            double stdDevDown,
            MovingAverageType maType,          
            Func<decimal[], decimal[], decimal[], decimal[], IndicatorSignal> signalLogic = null)
        {
            return TANet.Util.StaticClasses.Indicators.BollingerBands(input, period, stdDevUp, stdDevDown, maType, signalLogic);
        }

        /* CCI */

        private static CciResult CCI(List<Candle> candles,
            int period,            
            Func<decimal[], IndicatorSignal> signalLogic = null)
        {
            var high = candles.Select(c => c.High).ToArray();
            var low = candles.Select(c => c.Low).ToArray();
            var close = candles.Select(c => c.Close).ToArray();            

            return CCI(high, low, close, period, signalLogic);
        }
        private static CciResult CCI(decimal[] high,
            decimal[] low,
            decimal[] close,            
            int period,
            Func<decimal[], IndicatorSignal> signalLogic = null)
        {
            return TANet.Util.StaticClasses.Indicators.Cci(high, low, close, period, signalLogic);
        }

        /* MACD */

        private static MacdResult MACD(List<Candle> candles, 
            MovingAverageType fastMaType, 
            int fastPeriod, 
            MovingAverageType slowMaType, 
            int slowPeriod, 
            MovingAverageType signalMaType, 
            int signalPeriod, 
            IndicatorCalculationBase calculationBase = IndicatorCalculationBase.Close,
            Func<decimal[], decimal[], decimal[], IndicatorSignal> signalLogic = null)
        {
            decimal[] input;
            if (calculationBase == IndicatorCalculationBase.Close)
                input = candles.Select(c => c.Close).ToArray();

            else if (calculationBase == IndicatorCalculationBase.Open)
                input = candles.Select(c => c.Open).ToArray();

            else if (calculationBase == IndicatorCalculationBase.High)
                input = candles.Select(c => c.High).ToArray();

            else if (calculationBase == IndicatorCalculationBase.Low)
                input = candles.Select(c => c.Low).ToArray();

            else if (calculationBase == IndicatorCalculationBase.Volume)
                input = candles.Select(c => c.Volume).ToArray();

            else
                input = candles.Select(c => c.Close).ToArray();

            return MACD(input, fastMaType, fastPeriod, slowMaType, slowPeriod, signalMaType, signalPeriod, signalLogic);
        }
        private static MacdResult MACD(decimal[] input, 
            MovingAverageType fastMaType, 
            int fastPeriod, 
            MovingAverageType slowMaType, 
            int slowPeriod, 
            MovingAverageType signalMaType, 
            int signalPeriod,
            Func<decimal[], decimal[], decimal[], IndicatorSignal> signalLogic = null)
        {
            return TANet.Util.StaticClasses.Indicators.MacdExt(input, fastMaType, fastPeriod, slowMaType, slowPeriod, signalMaType, signalPeriod, signalLogic);
        }

        /* MA */

        private static MovingAverageResult MA(List<Candle> candles, 
            MovingAverageType maType, 
            int period, 
            IndicatorCalculationBase calculationBase = IndicatorCalculationBase.Close,
            Func<decimal[], decimal[], IndicatorSignal> signalLogic = null)
        {
            decimal[] input;
            if (calculationBase == IndicatorCalculationBase.Close)
                input = candles.Select(c => c.Close).ToArray();

            else if (calculationBase == IndicatorCalculationBase.Open)
                input = candles.Select(c => c.Open).ToArray();

            else if (calculationBase == IndicatorCalculationBase.High)
                input = candles.Select(c => c.High).ToArray();

            else if (calculationBase == IndicatorCalculationBase.Low)
                input = candles.Select(c => c.Low).ToArray();

            else if (calculationBase == IndicatorCalculationBase.Volume)
                input = candles.Select(c => c.Volume).ToArray();

            else
                input = candles.Select(c => c.Close).ToArray();

            return MA(input, maType, period, signalLogic);
        }
        private static MovingAverageResult MA(decimal[] input, 
            MovingAverageType maType, 
            int period,
            Func<decimal[], decimal[], IndicatorSignal> signalLogic = null)
        {
            return TANet.Util.StaticClasses.Indicators.Ma(input, maType, period, signalLogic);
        }

        /* MFI */

        private static MfiResult MFI(List<Candle> candles,
            int period,            
            Func<decimal[], IndicatorSignal> signalLogic = null)
        {
            var high = candles.Select(c => c.High).ToArray();
            var low = candles.Select(c => c.Low).ToArray();
            var close = candles.Select(c => c.Close).ToArray();
            var volume = candles.Select(c => c.Volume).ToArray();

            return MFI(high, low, close, volume, period, signalLogic);
        }
        private static MfiResult MFI(decimal[] high,
            decimal[] low,
            decimal[] close,
            decimal[] volume,
            int period,
            Func<decimal[], IndicatorSignal> signalLogic = null)
        {
            return TANet.Util.StaticClasses.Indicators.Mfi(high, low, close, volume, period, signalLogic);
        }

        /* P_SAR */

        private static ParabolicSarResult P_SAR(List<Candle> candles,
            double acceleration,
            double maximum,
            Func<decimal[], decimal[], decimal[], IndicatorSignal> signalLogic = null)
        {
            var high = candles.Select(c => c.High).ToArray();
            var low = candles.Select(c => c.Low).ToArray();

            return P_SAR(high, low, acceleration, maximum, signalLogic);
        }
        private static ParabolicSarResult P_SAR(decimal[] high,
            decimal[] low,
            double acceleration,
            double maximum,            
            Func<decimal[], decimal[], decimal[], IndicatorSignal> signalLogic = null)
        {
            return TANet.Util.StaticClasses.Indicators.ParabolicSar(high, low, acceleration, maximum, signalLogic);
        }

        /* RSI */

        private static RsiResult RSI(List<Candle> candles, 
            int period, 
            IndicatorCalculationBase calculationBase = IndicatorCalculationBase.Close, 
            Func<decimal[], IndicatorSignal> signalLogic = null)
        {
            decimal[] input;
            if (calculationBase == IndicatorCalculationBase.Close)
                input = candles.Select(c => c.Close).ToArray();

            else if (calculationBase == IndicatorCalculationBase.Open)
                input = candles.Select(c => c.Open).ToArray();

            else if (calculationBase == IndicatorCalculationBase.High)
                input = candles.Select(c => c.High).ToArray();

            else if (calculationBase == IndicatorCalculationBase.Low)
                input = candles.Select(c => c.Low).ToArray();

            else if (calculationBase == IndicatorCalculationBase.Volume)
                input = candles.Select(c => c.Volume).ToArray();

            else
                input = candles.Select(c => c.Close).ToArray();

            return RSI(input, period, signalLogic);
        }
        private static RsiResult RSI(decimal[] input,
            int period,
            Func<decimal[], IndicatorSignal> signalLogic = null)
        {
            return TANet.Util.StaticClasses.Indicators.Rsi(input, period, signalLogic);
        }

        /* STOCH */

        private static StochasticResult STOCH(List<Candle> candles,
            int fastKPeriod,
            MovingAverageType slowKMaType,
            int slowKPeriod,
            MovingAverageType slowDMaType,
            int slowDPeriod,
            Func<decimal[], decimal[], IndicatorSignal> signalLogic = null)
        {       
            var high = candles.Select(c => c.High).ToArray();
            var low = candles.Select(c => c.Low).ToArray();
            var close = candles.Select(c => c.Close).ToArray();

            return STOCH(high, low, close, fastKPeriod, slowKMaType, slowKPeriod, slowDMaType, slowDPeriod, signalLogic);
        }
        private static StochasticResult STOCH(decimal[] high,
            decimal[] low, 
            decimal[] close,
            int fastKPeriod,
            MovingAverageType slowKMaType,
            int slowKPeriod,
            MovingAverageType slowDMaType,
            int slowDPeriod,
            Func<decimal[], decimal[], IndicatorSignal> signalLogic = null)
        {
            return TANet.Util.StaticClasses.Indicators.Stochastic(high, 
                low, close, fastKPeriod, slowKMaType, slowKPeriod, slowDMaType, slowDPeriod, signalLogic);
        }

        /* WILL_R */

        private static WilliamsRResult WILL_R(List<Candle> candles,
            int period,
            Func<decimal[], IndicatorSignal> signalLogic = null)
        {
            var high = candles.Select(c => c.High).ToArray();
            var low = candles.Select(c => c.Low).ToArray();
            var close = candles.Select(c => c.Close).ToArray();            

            return WILL_R(high, low, close, period, signalLogic);
        }
        private static WilliamsRResult WILL_R(decimal[] high,
            decimal[] low,
            decimal[] close,            
            int period,
            Func<decimal[], IndicatorSignal> signalLogic = null)
        {
            return TANet.Util.StaticClasses.Indicators.WilliamsR(high, low, close, period, signalLogic);
        }

        #endregion
    }
}

using System;

namespace FreeQuant.Charting
{
	public interface IChartTransformation
	{
		double CalculateNotInSessionTicks(double x, double y);
		double CalculateRealQuantityOfTicks_Right(double x, double y);
		double CalculateRealQuantityOfTicks_Left(double x, double y);
		void GetFirstGridDivision(ref EGridSize gridSize, ref double min, ref double max, ref DateTime firstDateTime);
		double GetNextGridDivision(double firstTick, double prevMajor, int majorCount, EGridSize gridSize);
	}
}

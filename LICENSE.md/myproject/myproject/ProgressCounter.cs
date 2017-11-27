namespace Collage
{
    using System;

    internal class ProgressCounter
    {
        private readonly int totalNumberOfRows;
        private readonly int totalNumberOfColumns;

        public ProgressCounter(int totalNumberOfRows, int totalNumberOfColumns)
        {
            if (totalNumberOfRows <= 0)
            {
                throw new ArgumentOutOfRangeException("totalNumberOfRows", "общее кол-во строчек должно быть положит.числом");
            }

            if (totalNumberOfColumns <= 0)
            {
                throw new ArgumentOutOfRangeException("totalNumberOfColumns", "общее кол-во столбцов должно быть положит.числом");
            }

            this.totalNumberOfRows = totalNumberOfRows;
            this.totalNumberOfColumns = totalNumberOfColumns;
        }

        public int GetProgressPercentage(int colsCounter, int rowsCounter)
        {
            int tilesCompleted = rowsCounter * this.totalNumberOfRows + (colsCounter + 1);
            int totalTiles = this.totalNumberOfRows * this.totalNumberOfColumns;

            return (int)((float)tilesCompleted / (float)totalTiles * 100f);
        }
    }
}
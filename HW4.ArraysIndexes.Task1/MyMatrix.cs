using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.ArraysIndexes.Task1
{
    class MyMatrix
    {
        private List<List<double?>> _matrix;
        private int ColumnsCount { get { return _matrix.Count; } }

        public MyMatrix(int columnsCount, int rowsCount)
        {
            if (columnsCount <= 0 || rowsCount <= 0)
                throw new ArgumentException("Arguments must be > 0");
            else
            {
                _matrix = new List<List<double?>>(columnsCount);
                for (int i = 0; i < columnsCount; i++)
                {
                    _matrix.Add(new List<double?>(rowsCount));
                    for (int y = 0; y < rowsCount; y++)
                    {
                        _matrix[i].Add(null);
                    }
                }
            }          
        }

        public double? this[int columnIndex, int rowIndex]
        {
            get
            {
                if (columnIndex < 0 || rowIndex < 0 || columnIndex >= ColumnsCount || rowIndex >= _matrix[0].Count)
                    throw new IndexOutOfRangeException();
                else
                {
                    return _matrix[columnIndex][rowIndex];
                }
            }
            set
            {
                if (columnIndex < 0 || rowIndex < 0 || columnIndex >= ColumnsCount || rowIndex >= _matrix[0].Count)
                    throw new IndexOutOfRangeException();
                else
                {
                    _matrix[columnIndex][rowIndex] = value;
                }
            }
        }
        /// <summary>
        /// Resize matrix (trimmed cells will be lost)
        /// </summary>
        public void Resize(int columnsCount, int rowsCount)
        {
            if (columnsCount < 0 || rowsCount < 0)
                throw new ArgumentException("Arguments must be > 0");
            else
            {
                int initColumnsCount = ColumnsCount;
                int initRowsCount = _matrix[0].Count;

                if (columnsCount <= ColumnsCount)
                {
                    for (int i = 0; i < initColumnsCount; i++)
                    {
                        if(i >= columnsCount)
                            _matrix.RemoveAt(ColumnsCount - 1);

                        else if(rowsCount <= initRowsCount)
                            for (int j = rowsCount; j < initRowsCount; j++)
                                _matrix[i].RemoveAt(_matrix[i].Count - 1);

                        else if(rowsCount > initRowsCount)
                            for (int j = initRowsCount; j < rowsCount; j++)
                                _matrix[i].Add(null);
                    }
                }

                if(columnsCount > ColumnsCount)
                {
                    for (int i = 0; i < columnsCount; i++)
                    {
                        if(i >= initColumnsCount)
                        {
                            var listForAdd = new List<double?>();
                            for (int j = 0; j < rowsCount; j++)
                                listForAdd.Add(null);

                            _matrix.Add(listForAdd);
                        }

                        else if(rowsCount <= initRowsCount)
                            for (int j = rowsCount; j < initRowsCount; j++)
                                _matrix[i].RemoveAt(_matrix[i].Count - 1);

                        if(rowsCount > initRowsCount)
                            for (int j = initRowsCount; j < rowsCount; j++)
                                _matrix[i].Add(null);    
                    }
                }
            }
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            for (int i = 0; i < _matrix[0].Count; i++)
            {
                for (int j = 0; j < ColumnsCount; j++)
                {
                    if(_matrix[j][i] == null)
                        str.Append(String.Format("{0,-6}", "null"));
                    else
                        str.Append(String.Format("{0,-6}", _matrix[j][i]));
                }
                str.Append("\n");
            }

            return str.ToString();
        }
    }
}

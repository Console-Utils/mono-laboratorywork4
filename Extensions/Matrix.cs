using System;
using System.Globalization;
using System.Collections.Generic;

namespace LaboratoryWork.Extensions
{
  public static class Enumerable
  {
    public static T[,] Print<T>(this T[,] matrix, string delimiter = "")
    {
      if (matrix == null)
        throw new ArgumentNullException(nameof(matrix), "matrix can't be null");
      
      int rowCount = matrix.GetLength(0);
      int columnCount = matrix.GetLength(1);

      int[] maxLengths = new int[columnCount];

      for (var j = 0; j < columnCount; j++)
      {
        int maxLength = matrix[0, j].ToString().Length;
        for (var i = 1; i < rowCount; i++)
          if (matrix[i, j].ToString().Length > maxLength)
            maxLength = matrix[i, j].ToString().Length;
        maxLengths[j] = maxLength;
      }

      for (var i = 0; i < rowCount; i++)
      {
        for (var j = 0; j < columnCount; j++)
          Console.Write("{0}{1}", matrix[i, j].ToString().PadRight(maxLengths[j]), j + 1 >= columnCount ? string.Empty : delimiter);
        Console.WriteLine();
      }

      return matrix;
    }

    public static T[,] PrintLine<T>(this T[,] matrix, string delimiter = "")
    {
      if (matrix == null)
        throw new ArgumentNullException(nameof(matrix), "matrix can't be null");

      matrix.Print(delimiter);
      Console.WriteLine();
      return matrix;
    }
  }
}
﻿using System;

namespace SnakesAndLadders
{
  public interface IBoardPrinter
  {
    void Print(int tokenPosition);

    void Print(Token token);
  }
}

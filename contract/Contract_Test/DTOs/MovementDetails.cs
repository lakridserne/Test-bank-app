using System;
using System.Collections.Generic;
using System.Text;

namespace Contract_Test.DTOs
{
   public class MovementDetails
    {
        // NB!Amount should return of type Money and not long see on Assignment #1 - Mocking and TDD
        public long Amount { get; set; }
    }
}

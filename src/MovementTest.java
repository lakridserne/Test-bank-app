import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class MovementTest {


    @Test
    public  void testDatetimeN(){


        Bank bank = new Bank("124", "jons");

        Account account1  = new Account(bank, "jonas", "1234");

        Account account2  = new Account(bank, "Jack", "23456");

        Movement movement = new Movement("2020-03-02-12-02-10.001", 1000, "1235", "1234", "23456" );

        Movement actualResult = movement.getMovment();



        assertEquals(movement, actualResult);
    }
}


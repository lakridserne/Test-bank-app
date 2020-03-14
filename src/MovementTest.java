import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;
import java.time.Month;

import static org.junit.jupiter.api.Assertions.*;

class MovementTest {


    @Test
    public  void testDatetimeN(){


        Bank bank = new Bank("124", "jons");
        Customer c1 = new Customer("Jonas", "070887");
        Customer c2 = new Customer("Jonas", "070887");


        Account account1  = new Account(bank, c1, "3434" );
        Account account2 = new Account(bank, c2, "86924" );

        LocalDateTime localDateTime3 =
                LocalDateTime.of(2019, Month.MARCH, 28, 14, 33, 48);


        Movement expectedResult = new Movement(localDateTime3, 1000, account1, account2 );
        Class<? extends Movement> actualResult = expectedResult.getClass();

        assertEquals(expectedResult, actualResult);
    }
}


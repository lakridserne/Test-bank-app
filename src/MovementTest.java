import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class MovementTest {
    @Test
    public void testMovement() {
        Bank bank = new Bank("124", "jons");
        Customer c1 = new Customer("Jonas", "0708871213");
        Customer c2 = new Customer("Kasper", "0705894531");


        Account account1  = new Account(bank, c1, "3434" );
        Account account2 = new Account(bank, c2, "86924" );

        account1.transfer(1000, account2);

        assertEquals(account1.getBalance(), -1000);
        assertEquals(account2.getBalance(), 1000);
    }
}


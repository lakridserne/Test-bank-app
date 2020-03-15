import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

public class Account {
    private Bank Bank;
    private Customer Customer;
    private String number;
    private long balance = 0;
    private List<Movement> movements = new ArrayList<>();

    public Account(Bank IBank, Customer Customer, String number) {
        this.Bank = IBank;
        this.Customer = Customer;
        this.number = number;
    }

    public Bank getIBank() {
        return Bank;
    }

    public Customer getCustomer() {
        return Customer;
    }

    public String getNumber() {
        return number;
    }

    public long getBalance() {
        return balance;
    }

    public List<Movement> getMovements(Account withdraw) {
        List<Movement> returnList = new ArrayList<>();
        for(Movement movement : movements) {
            if(movement.getWithdrawalAccount().equals(withdraw)) {
                returnList.add(movement);
            }
        }
        return returnList;
    }

    public void transfer(long amount, Account target) {
        balance -= amount;
        target.balance += amount;
        Movement movement = new Movement(LocalDateTime.now(), amount, this, target);
        movements.add(movement);
    }

    public void transfer(long amount, String targetNumber) {
        String target = Bank.getAccount(targetNumber);
        transfer(amount, target);
    }

}

public class Account {
    private Bank Bank;
    private Customer customer;
    private String number;
    private long balance = 0;

    public Account(Bank IBank, Customer customer, String number) {
        this.Bank = IBank;
        this.customer = customer;
        this.number = number;
    }

    public Bank getIBank() {
        return Bank;
    }

    public Customer getCustomer() {
        return customer;
    }

    public String getNumber() {
        return number;
    }

    public long getBalance() {
        return balance;
    }

    public void transfer(long amount, Account target) {
        balance -= amount;
        target.balance += amount;
    }

    public void transfer(long amount, String targetNumber) {
        Account target = Bank.getAccount(targetNumber);
        transfer(amount, target);
    }

}

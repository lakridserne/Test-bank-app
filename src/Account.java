public class Account {
    private Bank Bank;
    private Customer Customer;
    private String number;
    private long balance = 0;

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

    public void transfer(long amount, Account target) {
        balance -= amount;
        target.balance += amount;
    }

    public void transfer(long amount, String targetNumber) {
        String target = Bank.getAccount(targetNumber);
        transfer(amount, target);
    }

}

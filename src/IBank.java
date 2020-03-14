public interface IBank {

    Account getAccount(String number);
    void registerAccount(Account account);
    Customer getCustomer(String number);
    void registerCustomer(Customer ICustomer);
    String getName();
}

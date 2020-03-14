import java.util.ArrayList;
import java.util.List;

public class Bank {


    private  String name;
    private  String cvr;
    private ArrayList<Account> accounts;
    private  Account account;
    private Bank bank;


    public String getCvr() {
        return cvr;
    }

    public void setCvr(String cvr) {
        this.cvr = cvr;
    }


    public Bank(String cvr, String name) {
        this.cvr = cvr;
        this.name = cvr;
    }

    public  Account getAccount(int nummber)
    {
            return account;
    }

    public List<Account> getAccounts(Customer customer){

        return accounts;
    }











}

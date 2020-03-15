import java.time.LocalDateTime;

public class Movement {

    private LocalDateTime localDateTime;
    private Account withdraw;
    private Account deposited;
    private LocalDateTime currentDate;
    private long amount;


    public Movement(LocalDateTime currentDate, long amount, Account withdraw, Account deposited) {
        this.currentDate = currentDate;
        this.amount = amount;
        this.withdraw = withdraw;
        this.deposited = deposited;
    }

    public Account getWithdrawalAccount() { return withdraw; }
    public Account getDepositAccount() { return deposited; }
}

import java.time.LocalDate;
import java.time.LocalDateTime;
import java.util.Date;

public class Movement {

    private LocalDateTime localDateTime;
    private Account withdraw;
    private Account deposited;
    private LocalDateTime currentDate;
    private int amount;


    public Movement(LocalDateTime currentDate, int amount, Account withdraw, Account deposited) {
        this.currentDate = currentDate;
        this.amount = amount;
        this.withdraw = withdraw;
        this.deposited = deposited;
    }
}

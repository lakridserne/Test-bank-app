import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;

import static org.junit.jupiter.api.Assertions.*;

class MovementTest {


    @Test
    public  void testDatetime(){

        Movement movement = new Movement(2020-03-02-12-02-10.001, 20000);

        LocalDateTime expected = 2020-03-02-12-02-10.001;


        LocalDateTime actualResult = movement.getDate();

        assertEquals(expected, actualResult);
    }
}


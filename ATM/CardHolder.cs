namespace ATM;

public class CardHolder
{
    string firstName;
    string lastName;
    int cardNumber;
    int pin;
    double balance;

    public CardHolder(string firstName, string lastName, int cardNumber, int pin, double balance)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.cardNumber = cardNumber;
        this.pin = pin;
        this.balance = balance;
    }

    public string FirstName
    {
        get => firstName;
        set => firstName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string LastName
    {
        get => lastName;
        set => lastName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int CardNumber
    {
        get => cardNumber;
        set => cardNumber = value;
    }

    public int Pin
    {
        get => pin;
        set => pin = value;
    }

    public double Balance
    {
        get => balance;
        set => balance = value;
    }
}
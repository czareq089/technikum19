using Restaurant;

public class ReservationBuilder
{
    private readonly Reservation reservation;

    public ReservationBuilder()
    {
        reservation = new Reservation();
    }

    public ReservationBuilder(Reservation reservation)
    {
        this.reservation = reservation ?? throw new ArgumentNullException(nameof(reservation));
    }

    public ReservationBuilder SetName(string name)
    {
        reservation.Name = name;
        return this;
    }

    public ReservationBuilder SetType(string type)
    {
        reservation.Type = type;
        return this;
    }

    public ReservationBuilder SetDate(DateTime date)
    {
        reservation.Date = date;
        return this;
    }

    public ReservationBuilder SetAdditionalInfo(string info)
    {
        reservation.AdditionalInfo = info;
        return this;
    }

    public ReservationBuilder SetReservationNumber(int number)
    {
        reservation.ReservationNumber = number;
        return this;
    }

    public Reservation Build()
    {
        Logger.GetInstance().Log("Utworzono nową rezerwację.");
        return reservation;
    }
}

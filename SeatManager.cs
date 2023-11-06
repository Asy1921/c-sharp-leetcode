// 1845.Seat Reservation Manager
// Medium
// 1.2K
// 78
// Companies
// Design a system that manages the reservation state of n seats that are numbered from 1 to n.

// Implement the SeatManager class:

// SeatManager(int n) Initializes a SeatManager object that will manage n seats numbered from 1 to n.All seats are initially available.
// int reserve() Fetches the smallest-numbered unreserved seat, reserves it, and returns its number.
// void unreserve(int seatNumber) Unreserves the seat with the given seatNumber.
namespace LeetCodeProblems;
public partial class LCProblems
{


    SortedSet<int> availableSeats;

    public void SeatManager(int n)
    {
        availableSeats = new SortedSet<int>(Enumerable.Range(1, n));
    }

    public int Reserve()
    {
        if (availableSeats.Count == 0)
        {
            return -1; // No available seats.
        }

        int seat = availableSeats.Min;
        availableSeats.Remove(seat);
        return seat;
    }

    public void Unreserve(int seatNumber)
    {
        availableSeats.Add(seatNumber);
    }

}

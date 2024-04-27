// 2043. Simple Bank System
// Solved
// Medium
// Topics
// Companies
// Hint
// You have been tasked with writing a program for a popular bank that will automate all its incoming transactions (transfer, deposit, and withdraw). The bank has n accounts numbered from 1 to n. The initial balance of each account is stored in a 0-indexed integer array balance, with the (i + 1)th account having an initial balance of balance[i].

// Execute all the valid transactions. A transaction is valid if:

// The given account number(s) are between 1 and n, and
// The amount of money withdrawn or transferred from is less than or equal to the balance of the account.
// Implement the Bank class:

// Bank(long[] balance) Initializes the object with the 0-indexed integer array balance.
// boolean transfer(int account1, int account2, long money) Transfers money dollars from the account numbered account1 to the account numbered account2. Return true if the transaction was successful, false otherwise.
// boolean deposit(int account, long money) Deposit money dollars into the account numbered account. Return true if the transaction was successful, false otherwise.
// boolean withdraw(int account, long money) Withdraw money dollars from the account numbered account. Return true if the transaction was successful, false otherwise.

public class Bank
{
    private long[] _accounts;
    public Bank(long[] balance)
    {
        _accounts = balance;
    }

    public bool Transfer(int account1, int account2, long money)
    {
        //Check if both accounts are valid
        if (account1 < 0 || account2 < 0 || account1 > _accounts.Length || account2 > _accounts.Length || _accounts[account1 - 1] < money)
        {
            return false;
        }
        _accounts[account1 - 1] -= money;
        _accounts[account2 - 1] += money;
        return true;
    }

    public bool Deposit(int account, long money)
    {
        if (account < 0 || account > _accounts.Length)
        {
            return false;
        }
        _accounts[account - 1] += money;
        return true;
    }

    public bool Withdraw(int account, long money)
    {
        if (account < 0 || account > _accounts.Length || (_accounts[account - 1] < money))
        {
            return false;
        }
        _accounts[account - 1] -= money;
        return true;
    }
}

/**
 * Your Bank object will be instantiated and called as such:
 * Bank obj = new Bank(balance);
 * bool param_1 = obj.Transfer(account1,account2,money);
 * bool param_2 = obj.Deposit(account,money);
 * bool param_3 = obj.Withdraw(account,money);
 */
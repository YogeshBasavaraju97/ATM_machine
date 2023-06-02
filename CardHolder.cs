using System;
namespace ATM_machine_Application
{
	public class CardHolder
	{
		string cardNum;
		int pin;
		string firstName;
		string lastName;
		double balance;

		public CardHolder(string CardNum, int pin, string firstName, string lastName, double balance)
		{
			this.cardNum = CardNum;
			this.pin = pin;
			this.firstName = firstName;
			this.lastName = lastName;
			this.balance = balance;

		}

		public string getNum()
		{
			return cardNum;
		}
		public int getPin() { return pin; }

		public string getFirstName() { return firstName; }

		public string getLastName() { return lastName; }

		public double getBalance() { return balance; }

		public void setNum(string cardNum) { this.cardNum = cardNum; }

		public void setPin(int pin) { this.pin = pin; }

		public void setFirstName(string firstName) { this.firstName = firstName; }

		public void setLastName(string LastName) { this.lastName = LastName; }

		public void setbalance(double balance) { this.balance = balance; }

		
	}
}


var bankaccount = new Bankaccount(1,1000,"Mustafo");
bankaccount.Deposit(1000);
bankaccount.Withdraw(100);

bankaccount.FreezeAccount();
bankaccount.Deposit(2000);

bankaccount.UnfreezeAccount();
bankaccount.Deposit(500.00m);

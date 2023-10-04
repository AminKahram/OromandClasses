using ConcurrencyAndAsynchrony.Blocking;
using ConcurrencyAndAsynchrony.CreateAndStartThread;
using ConcurrencyAndAsynchrony.JoinAndSleep;
using ConcurrencyAndAsynchrony.SharedAndLocalState;

//CharPrinter.Start();

//----------------------------------------------------

//JoinAndSleepSample.Start();

//JoinAndSleepSample joinAndSleepSample = new();
//joinAndSleepSample.JoinTest();
//joinAndSleepSample.SleepTest();

//----------------------------------------------------

//BlockingSample blockingSample = new();
//blockingSample.ThreadStateCheck();

//----------------------------------------------------

SharedAndLocalStateSample sharedAndLocalStateSample = new();
sharedAndLocalStateSample.start();
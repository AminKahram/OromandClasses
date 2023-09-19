// See https://aka.ms/new-console-template for more information
using CollectionSample.ListSamples;

//Console.WriteLine("Hello, World!");
ListSample sample = new ListSample() ;
sample.PrintCapacity();

sample.AddMember("1");
sample.PrintCapacity();
sample.PrintCount();

sample.AddMember("2");
sample.PrintCapacity();
sample.PrintCount();

sample.AddMember("3");
sample.PrintCapacity();
sample.PrintCount();

sample.AddMember("4");
sample.PrintCapacity();
sample.PrintCount();


sample.AddMember("5");
sample.PrintCapacity();
sample.PrintCount();

sample.Ensure();
sample.PrintCapacity();

for (int i = 0; i < 12; i++)
{
    sample.AddMember(i.ToString());
}
sample.PrintCapacity();

sample.Trim();
sample.PrintCapacity();

var listReadOnly = sample.GetReadOnly();
 
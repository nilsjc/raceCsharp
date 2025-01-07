using raceLab;
int tools = 100;
int number = 1000;
List<Thread> threads = [];
for(int x=0; x < tools; x++)
{
    string name = $"tool-{x}";
    DataGenerator generator = new (name, number);
    threads.Add(new Thread(()=>{
        foreach(var rx in generator.GetSingleObject())
        {
            DataHandlers.Sort(rx);
        }
    }));
}
Console.WriteLine($"starting {tools} threads");
threads.ForEach(x => x.Start());
threads.ForEach(x => x.Join());
DataHandlers.Analyze();

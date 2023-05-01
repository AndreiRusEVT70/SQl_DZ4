namespace DZ3BD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Dz3Context context = new Dz3Context())
            {
                Dz3 nick = new Dz3(null, "Вова", 29);

                context.Dz3s.Add(nick);
                context.SaveChanges();
                Output(context);

                nick.Age = 35;
                context.Dz3s.Update(nick);
                context.SaveChanges();
                Output(context);

                context.Dz3s.Remove(nick);
                context.SaveChanges();
                Output(context);
            }
        }

        static void Output(Dz3Context context)
        {
            foreach (var user in context.Dz3s)
            {
                Console.WriteLine(user);
            }
        }

    }
}
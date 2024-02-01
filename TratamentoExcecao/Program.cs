using TratamentoExcecao.Entities;
using TratamentoExcecao.Entities.Exepetions;

class Program
{
    public static void Main(string[] args)
    {

        try
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double inicialBalance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(number, holder, inicialBalance, withdrawLimit);

            Console.Write("Enter amount for withdraw: ");
            double withdraw = double.Parse(Console.ReadLine());

            account.Withdraw(withdraw);

            Console.WriteLine(account.ToString());
        }
        catch (DomainExeption e)
        {
            Console.WriteLine(e.Message);
        } catch (NullReferenceException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }

    }
}
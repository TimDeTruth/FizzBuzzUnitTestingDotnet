namespace FizzBuzzLibrary;
public class FizzBuzz
{
    public string GetResult(int nmbr)
    {

        if (nmbr < 0) throw new Exception("Number must be greater than 0");

        // throw an exception if nmbr is greater than 1000
        if (nmbr > 1000) throw new Exception("Number must be less than 1000");

        // throw an exceptio if nmbr is 0
        if (nmbr == 0) throw new Exception("Number must be greater than 0");


        string result = "";

        for (int ndx = 1; ndx < nmbr + 1; ndx++)
        {
            if (ndx % 3 == 0 && ndx % 5 == 0)
                result += "FizzBuzz ";
            else if (ndx % 5 == 0)
                result += "Buzz ";
            else if (ndx % 3 == 0)
                result += "Fizz ";
            else
                result += ndx.ToString() + " ";
        }

        return result;
    }


}

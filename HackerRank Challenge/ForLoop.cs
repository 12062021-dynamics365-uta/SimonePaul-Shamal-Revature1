

    public static void Main()
	{
		for (int i = 0; i < grades.Count; i++) 
        {

                if (grades[i] >= 38) //if any the grade in array is >= 38 
            {
                int nextMultiple = grades[i]; //We store the grade in nextMultiple
                while (nextMultiple % 5 != 0) //When nextMultiple moodulas 5 
                {
                    nextMultiple++;
                }
                if(nextMultiple - grades[i] < 3)
                {
                    grades[i] = nextMultiple;
                }
           
	}
}
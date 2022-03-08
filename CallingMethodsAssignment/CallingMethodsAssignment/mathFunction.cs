namespace CallingMethodsAssignment
{
    class mathFunction
    {
        //this method adds 10 to user's input
        public static int addInt(int num)
        {
            int myNum = num;
            int myNumAdd = myNum + 10;
            return myNumAdd;
        }

        //this method subtracts 5 to user's input
        public static int subInt(int num)
        {
            int myNum = num;
            int myNumSub = myNum - 5;
            return myNumSub;
        }

        //this method multiplies 10 to user's input
        public static int multInt(int num)
        {
            int myNum = num;
            int myNumMult = myNum * 10;
            return myNumMult;
        }
    }
}


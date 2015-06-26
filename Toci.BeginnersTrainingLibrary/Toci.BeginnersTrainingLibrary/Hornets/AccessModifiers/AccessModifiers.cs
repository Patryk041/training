namespace Toci.BeginnersTrainingLibrary.Hornets.AccessModifiers
{
    public class AccessModifiers
    {

        protected string ProtectedVariable;
        //private, public, internal, protected, 
        // sealed, virtual, override, abstract, static

        private string PrivateMethod()
        {
            
            return "I am private method";
        }

        public string CosInnego()
        {

            return "I am public method";
        }

        protected virtual void VirtualMethod()
        {
            
        }

        protected void NonVirtual()
        {
            
        }


        class SecondAcessModifierClass
        {


            public void SomeMethod()
            {
                
            AccessModifiers accessModifiers = new AccessModifiers();
           // accessModifiers.
            }

        }
      
    }

    public abstract class SecondAcessModifierClass : AccessModifiers
    {
        protected SecondAcessModifierClass()
        {
           
        }

      
        public void SomeMethod()
            {
                

           
            AccessModifiers accessModifiers = new AccessModifiers();
            //accessModifiers
            
                //ProtectedVariable
            }



    }


    public class ThirdAccessClass 
    {
        

    }

    
}

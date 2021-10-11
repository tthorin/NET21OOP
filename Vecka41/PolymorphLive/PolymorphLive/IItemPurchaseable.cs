namespace PolymorphLive
{
    internal interface IItemPurchaseable
    {
        //har så lite som möjligt (minsta gemensamma nämnare) 

        //allt är automatiskt public, man skriver inte åtkomstgrad
        //inget kan vara static
        //bara deklarationer, ingen kod
        //inga variabler, men kan ha properties
        int Add(int x, int y);

    }
    //klass har allt som kan tänkas behövs för de som ärver
    //sealed tillåter inte arv
    //new strunta i regler och skapa metoder ändå, ignorerar sealed osv. (funkar inte med polymorphism)
    //man kan bara ärva en klass
    class Store
    {
        protected int Id = 0;

        public virtual string GetName()
        {
            return "Store";
        }
    }


}
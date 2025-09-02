using System;

namespace LesBases
{
    public abstract class Publication : Article
    {
        protected Publication(string titre, decimal prix) 
            : base(titre, prix) {}

        public abstract void PublishDetails();
    }
}

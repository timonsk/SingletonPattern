namespace SingletonPattern
{
    internal class SingletonProduct
    {
        private static SingletonProduct _singletonProduct;

        private SingletonProduct()
        {
        }

        private int Size { get; set; }

        public static SingletonProduct Creat()
        {
            if (_singletonProduct == null)
            {
                _singletonProduct = new SingletonProduct();
                return _singletonProduct;
            }
            return _singletonProduct;
        }

        public void ChangeSize(int size)
        {
            Size = size;
        }

        public int GetSize()
        {
            return Size;
        }
    }
}
namespace SingletonPattern
{
    internal class SingletonProduct
    {
        private static SingletonProduct _singletonProduct;

        private SingletonProduct()
        {
        }

        private int _size { get; set; }

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
            _size = size;
        }

        public int GetSize()
        {
            return _size;
        }
    }
}
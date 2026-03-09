namespace ProjectProduct.ASPMVC.Mapper
{
    public static class Mapper
    {
        #region Product

        public static Models.Product.ListItemViewModel ToListItem(this BLL.Entities.Product entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            return new Models.Product.ListItemViewModel()
            {
                ProductId = entity.ProductId,
                Name = entity.Name,
            };
        }

        #endregion
    }
}

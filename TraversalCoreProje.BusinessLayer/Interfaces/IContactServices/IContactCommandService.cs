﻿using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IContactCommandService:IGenericCommandService<UpdateContactDto,CreateContactDto,Contact>
    {
    }
}
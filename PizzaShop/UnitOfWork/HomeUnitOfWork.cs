﻿using Ninject;
using PizzaShop.Models.PizzaShopModels.CMS;
using PizzaShop.Repositories;
using PizzaShop.Repositories.PizzaShopRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PizzaShop.UnitOfWork
{
    public class HomeUnitOfWork : UnitOfWork
    {
        public HomeUnitOfWork(DbContext conetxt) : base(conetxt)
        {
        }

        [Inject]
        public IMenuItemRepository MenuItemRepository { get;  set; }

        [Inject]
        public IGetRepository<InformationItem> InformationItemRepository { get; set; }

        [Inject]
        public IGetRepository<SliderItem> SliderItemRepository { get; set; }

        [Inject]
        public IGetRepository<Event> EventRepository { get; set; }

        [Inject]
        public IGetRepository<New> NewRepository { get; set; }

        [Inject]
        public IGetRepository<GalleryItem> GalleryRepository { get; set; }
    }
}
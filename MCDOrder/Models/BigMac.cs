﻿using System;
using System.Collections.Generic;
using System.Text;
using MCDOrder.BusinessModel;

namespace MCDOrder.Models {
  class BigMac : IMenu{
    private string _menuName = "Big Mac Burger";
    private string _customerName;

    private IIngredients _ingredients;
    internal BigMac(IIngredients ingredients) {
      _ingredients = ingredients;
    }
    string IMenu.MenuName() {
      return _menuName;
    }
    void IMenu.CustomerName(string customerName) {
      _customerName = customerName;
    }
    internal void CookBigMac() {
      _ingredients.Bread();
      _ingredients.Meat();
      _ingredients.Cheese();
      _ingredients.Lettuce();
      _ingredients.Bread();
      _ingredients.Meat();
      _ingredients.Cheese();
      _ingredients.Lettuce();
      _ingredients.Onion();
      _ingredients.Bread();

      Status();
    }
    internal void Status() {
      Console.WriteLine(_customerName + " : " + _menuName + " Done");
    }
  }
}

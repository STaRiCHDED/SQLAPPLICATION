# SQLAPPLICATION
## Uml схема базы данных интернет-магазина
![alt text](https://github.com/STaRiCHDED/SQLAPPLICATION/blob/main/image.png?raw=true)
### Buyers
Таблица покупателей, записанных в нашу базу данных\
**BuyerId** - ID покупателя\
**Name** - Имя\
**LastName** - Фамилия\
**Patronymic** - Отчество\
**WalletId**- ID кошелька
### Wallets
Таблица кошельков, записанных в нашу базу данных\
**WalletId** - ID кошелька\
**CardNumber** - Номер карты\
**Description** - Описание карты (какому банку она принадлежит)
### Products
Таблица товаров, записанных в нашу базу данных\
**ProductId** - ID товара\
**Name** - Название товара\
**Cost** - Цена товара\
**Description** - Описание товара
### Sales
Таблица покупок, записанных в нашу базу данных\
**SalesId** - ID покупки\
**ProductId** - ID товара\
**BuyerId** - ID покупателя\
**Date** - Дата оформления покупки

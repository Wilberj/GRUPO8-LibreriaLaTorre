USE [BDproyectolibreria]
GO
--Procedimiento para sumar articulos en el stock

SELECT * FROM [stock_articulos]
SELECT 'Id_StockArticulo', SUM('Cantidad') FROM [stock_articulos]
GROUP BY 'Id_StockArticulo' 

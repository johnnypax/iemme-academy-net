-- string variabile = "Giovanni"
DECLARE @variabile VARCHAR(250) = 'Giovanni';

-- PRINT @variabile;
SELECT @variabile;

----------------------------------------------------

DECLARE @variabileUno VARCHAR(250);
DECLARE @variabileDue INT;
DECLARE @variabileTre INT;

SET @variabileUno = 'Giovanni';
SET @variabileDue = 5;
SET @variabileTre = 8;

-- SELECT @variabileDue + @variabileTre;

-- SELECT @variabileUno + ' ha ' + CAST(@variabileDue AS VARCHAR);

SELECT @variabileUno + ' ha ' + CAST(@variabileDue + @variabileTre AS VARCHAR) + ' anni';
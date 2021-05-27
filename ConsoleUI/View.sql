create view RecipeDetailsByIngredients AS
SELECT Recipes.Id as REcipeID,Recipes.Name as REcipeName,Recipes.RecipeExplanation,Recipes.ImageUrl,Recipes.CategoryId,
Ingredients.Id as IngredientID,Ingredients.Name as IngredientsName
	 
FROM Recipes 
INNER JOIN RecipeIngredientRelation 
ON Recipes.Id=RecipeIngredientRelation.RecipeId 
INNER JOIN Ingredients 
ON  RecipeIngredientRelation.IngredientId = Ingredients.Id
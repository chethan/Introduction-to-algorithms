power x 1 = x
power x 0 = 1
power x n 
	| (rem n 2) == 0 = square (power x (n `div` 2))
	| otherwise = x * (square (power x (n `div` 2)))
  where square n = (n * n)
	
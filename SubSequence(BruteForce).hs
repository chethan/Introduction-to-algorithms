import Data.List

flatmap func seq = foldr (\x acc -> x ++ acc) [] (map func seq)
merge_lists xs ys func = flatmap (\x-> (map (\y -> (func x y)) ys)) xs							  

is_subsequence _ [] = True
is_subsequence [] _ = False
is_subsequence (x:xs) (s:sub) | x == s = is_subsequence xs sub
							  | otherwise = is_subsequence xs (s:sub)

							  
my_subsequences [] = [[]]
my_subsequences [x] = [[x],[]]
my_subsequences (x:xs) = merge_lists (my_subsequences (x:[])) (my_subsequences xs) (++)

lcs xs ys = let 
			 test [] = 0
			 test (s:subs) 
					| is_subsequence ys s =  length s
					| otherwise = test subs
		in test (sortBy (\a b-> compare (length b) (length a)) (my_subsequences xs)) 
							  
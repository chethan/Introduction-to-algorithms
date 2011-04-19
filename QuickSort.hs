-- TODO : add randmozied quick sort i.e., choose the pivot randomly
-- TODO : try to do inplace partition instead of creating new array each time

quick_sort [] = []
quick_sort (x:xs) = let 
					 partition _ [] (l,e,g) = (l,e,g)
					 partition p (x:xs) (l,e,g) 
							| x < p = partition p (xs) (x:l,e,g)
							| otherwise = partition p (xs) (l,e,x:g)
					 (lesser,equal,greater) = partition x xs ([],x,[])	
				  in (quick_sort lesser) ++ [equal] ++ (quick_sort greater)
	
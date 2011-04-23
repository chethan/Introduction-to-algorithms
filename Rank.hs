partition _ [] (l,e,g) = (l,e,g)
partition p (x:xs) (l,e,g) 	| x < p = partition p (xs) (x:l,e,g)
							| otherwise = partition p (xs) (l,e,x:g)
							
rank elem [] = -1
rank elem (x:xs) = let  
						temp_rank ([],e,[]) elem rank 
							| elem == e = rank + 1
							| otherwise = -1
						temp_rank ([],e,(g:gs)) elem rank 
							| elem == e = rank + 1
							| elem > e = temp_rank (partition g gs ([],g,[])) elem (rank + 1)
							| otherwise = -1
						temp_rank ((l:ls),e,[]) elem rank 
							| elem == e = (length (l:ls)) +  rank + 1
							| elem < e = temp_rank (partition l ls ([],l,[])) elem rank 
							| otherwise = -1
						temp_rank (l:ls,e,g:gs) elem rank 
							| elem == e  = (length (l:ls)) + rank + 1
							| elem < e = temp_rank (partition l ls ([],l,[])) elem rank
							| otherwise = temp_rank (partition g gs ([],g,[])) elem (rank + (length (l:ls)) + 1)
				   in temp_rank (partition x xs ([],x,[])) elem 0						
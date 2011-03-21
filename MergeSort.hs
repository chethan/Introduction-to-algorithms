merge xs [] = xs
merge [] ys = ys
merge (x:xs) (y:ys) | x <= y = x : (merge xs (y:ys))
					| otherwise = y : (merge (x:xs) ys)
					
split [] = ([],[])
split [x] = ([x],[])
split (x:y:xs) = (x:ys,y:zs)
                 where (ys,zs) = split xs


merge_sort [] = []
merge_sort [x] = [x]
merge_sort xs = merge (merge_sort split1) (merge_sort split2)
                where (split1,split2) = split xs 
					
					
					
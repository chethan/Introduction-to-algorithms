term = ((1,1),(1,0))

fibbonaci n = let 
				first t =  fst (fst t)
				second t = fst (snd t)
				third t =  snd (fst t)
				fourth t = snd (snd t)
				mult t1 t2 = 
						(((first t1) * (first t2) + (second t1) * (third t2),
						 (first t1) * (second t2) + (second t1) * (fourth t2)),
						 ((third t1) * (first t2) + (fourth t1) * (third t2),
						 (third t1) * (second t2) + (fourth t1) * (fourth t2)))
				square t = mult t t
				power t 0 = term
				power t 1 =  t
				power t n| (rem n 2)==0 = square (power t (n `div` 2))
						 | otherwise = mult t (square (power t (n `div` 2)))
			 in second (power term n) 	  
invalid_index = -1

binary_search xs key = let 
				binary_search_temp xs key low high 
						| high < low = invalid_index
						| xs!!mid < key = binary_search_temp xs key (mid+1) high 
						| xs!!mid > key = binary_search_temp xs key low (mid-1)
						| otherwise = mid
					where mid = (low + ((high-low) `div` 2))
			in binary_search_temp xs key 0 ((length xs)-1)
let rec recBouncingBall (h: float) (bounce: float) (window: float) (times: int) =
    match h with 
    | 0.0 -> -1 
    | _ -> 
        match bounce with 
        | 0.0 -> -1 
        | _ -> 
            match window with 
            | 0.0 -> -1 
            | _ -> 

        if ((h * bounce) > window) then
            recBouncingBall (h* bounce) bounce window (times + 1)
        else 
        counter

let bouncingBall (h: float) (bounce: float) (window: float) =
    // Conditions 
    if h <= 0 then 
        -1
    else if bounce <= 0 || bounce >= 1 then
        -1
    else if window > h then  
        -1
    else
        recBouncingBalls h bounce window times 
    
    

        
        

        
        
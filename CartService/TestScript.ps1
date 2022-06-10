# insert carts
Invoke-RestMethod https://localhost:44301/cartservice -Method POST -Body (@{name = "Cart1"; ImageInfo = @{url = 'url_1'; altText='alt_1'}; price=1; quantity=1 } | ConvertTo-Json) -ContentType "application/json; charset=utf-8"
Invoke-RestMethod https://localhost:44301/cartservice -Method POST -Body (@{name = "Cart2"; ImageInfo = @{url = 'url_2'; altText='alt_2'}; price=2; quantity=2 } | ConvertTo-Json) -ContentType "application/json; charset=utf-8"
Invoke-RestMethod https://localhost:44301/cartservice -Method POST -Body (@{name = "Cart3"; ImageInfo = @{url = 'url_3'; altText='alt_3'}; price=3; quantity=3 } | ConvertTo-Json) -ContentType "application/json; charset=utf-8"
Invoke-RestMethod https://localhost:44301/cartservice -Method POST -Body (@{name = "Cart4"; ImageInfo = @{url = 'url_4'; altText='alt_4'}; price=4; quantity=4 } | ConvertTo-Json) -ContentType "application/json; charset=utf-8"
Invoke-RestMethod https://localhost:44301/cartservice -Method POST -Body (@{name = "Cart5"; ImageInfo = @{url = 'url_5'; altText='alt_5'}; price=5; quantity=4 } | ConvertTo-Json) -ContentType "application/json; charset=utf-8"


# list carts
Invoke-RestMethod https://localhost:44301/cartservice -Method GET

# delete 3 carts
Invoke-RestMethod https://localhost:44301/cartservice/1 -Method Delete
Invoke-RestMethod https://localhost:44301/cartservice/3 -Method Delete
Invoke-RestMethod https://localhost:44301/cartservice/5 -Method Delete

# list carts
Invoke-RestMethod https://localhost:44301/cartservice -Method GET
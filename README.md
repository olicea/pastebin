# Pastebin

this is a pastebin implementation

## testing

add a paste
```
curl -K POST https://127.0.0.1:5001/paste -k -H "Content-Type: application/json" -d '{"Name":"test","Content":"foo", "ShortUrl":"foo"}' -v
```

get a paste
```
curl -K GET https://127.0.0.1:5000/pastebin/test -k
```
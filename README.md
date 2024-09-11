# hc-5054

https://github.com/ChilliCream/graphql-platform/issues/5054

- `dotnet watch --no-hot-reload`
- http://localhost:5095

```graphql
query {
  items {
    subject
    user {
      username
    }
  }
}
```

Error:

> Property 'System.String Username' is not defined for type 'System.String' (Parameter 'property')

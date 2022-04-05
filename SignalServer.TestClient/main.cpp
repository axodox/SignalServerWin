#include "pch.h"

using namespace winrt;
using namespace Windows::Foundation;
using namespace Windows::Web::Http;

int main()
{
  init_apartment();
  
  printf("Building query...\n");

  Uri uri{ L"http://localhost:5000/coverage/generate" };

  HttpMultipartFormDataContent content{};
  content.Add(HttpStringContent(L"5.6"), L"NumericArgument");

  printf("Awaiting query...\n");

  HttpClient client{};
  auto result = client.TryPostAsync(uri, content).get();
  auto response = result.ResponseMessage();

  auto responseString = response.Content().ReadAsStringAsync().get();

  if (result.Succeeded())
  {
    printf("Query succeeded.\n");
  }
  else
  {
    printf("Query failed.\n");
  }
}

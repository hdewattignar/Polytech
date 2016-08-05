#include "AISolution.h"

AISolution::AISolution(char *user, char *pass,
	char *agent, char *host, int port)
	: TTRClient(user, pass, agent, host, port)
{
}


AISolution::~AISolution()
{
}

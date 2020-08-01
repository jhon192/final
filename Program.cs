using System;

namespace final
{
    static class Program
    {
        static void Main(string[] args)
        {
            //perdon fue un poco largo XD
            long username = 40234533160;
            long clave = 123456;
            string rol = "Supervisor";
            long username2 = 40231233160;
            long clave2 = 654321;
            string rol2 = "Administrador";
            long username3 = 40233213160;
            long clave3 = 987654;
            string rol3 = "Vendedor";
            string estado1 = "activo";
            string estado2 = "inactivo";
            int acceso;
            Console.WriteLine("Que Accion usted desea tomar:? ");
            Console.Write("\n 1- Iniciar sesion \n 2- ver registros de Activos o Inactivos \n >");
            acceso = Convert.ToInt32(Console.ReadLine());
            if (acceso == 1)
            {
                Console.Write("Ingrese su Usuario: ");
                username = Convert.ToInt64(Console.ReadLine());               
                Console.Write("Ingrese su clave: ");
                clave = Convert.ToInt64(Console.ReadLine());
                if (username == 40234533160 && clave == 123456)
                {
                    Console.WriteLine("\nEstas dentro!");
                    Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username, rol, estado1);
                }
                
                
                else if (username == 40231233160 && clave == 654321)
                {
                    Console.WriteLine("\nEstas dentro!");
                    Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username2, rol2, estado2);
                }
                
                else if (username == 40231233160 && clave == 987654)
                {
                    Console.WriteLine("\nEstas dentro!");
                    Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username3, rol3, estado1);
                }

                else
                {
                    while (username != 40234533160 && clave != 123456 || username != 40231233160 && clave != 654321
                     || username != 40231233160 && clave != 987654)
                    {
                        Console.WriteLine("\nError a ingresado un dato incorrecto");
                        Console.WriteLine();
                        Console.Write("Ingrese su Usuario: ");
                        username = Convert.ToInt64(Console.ReadLine());
                        Console.Write("Ingrese su clave: ");
                        clave = Convert.ToInt64(Console.ReadLine());

                        if (username == 40234533160 && clave == 123456)
                        {
                            Console.WriteLine("\nEstas dentro!");
                            Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username, rol, estado1);
                        }
                        
                        else if (username == 40231233160 && clave == 654321)
                        {
                            Console.WriteLine("\nEstas dentro!");
                            Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username2, rol2, estado2);
                        }
                        
                        else if (username == 40231233160 && clave == 987654)
                        {
                            Console.WriteLine("\nEstas dentro!");
                            Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username3, rol3, estado1);
                        }

                        else
                        {
                            Console.WriteLine("Hubo un error");
                        }
                    }
                }
            }

            else if (acceso == 2)
            {
                Console.WriteLine("El usuario {0}, su rol {1} y su estado es {2}", username, rol, estado1);
                Console.WriteLine("El usuario {0}, su rol {1} y su estado es {2}", username2, rol2, estado2);
                Console.WriteLine("El usuario {0}, su rol {1} y su estado es {2}", username3, rol3, estado1);
                Console.Write("Desea activar todos los inactivo si/no?: ");
                string confi = Console.ReadLine();
                if (confi == "si")
                {
                    Console.WriteLine("\nYA ESTA ACTIVADO!!!");
                    Console.WriteLine("GRACIAS!!!");
                    Console.WriteLine("El usuario {0}, su rol {1} y su estado es {2}", username, rol, estado1);
                    Console.WriteLine("El usuario {0}, su rol {1} y su estado es {2}", username2, rol2, estado1);
                    Console.WriteLine("El usuario {0}, su rol {1} y su estado es {2}", username3, rol3, estado1);
                    Console.WriteLine("\nIniciar Sesion");
                    Console.Write("Ingrese su Usuario: ");
                    username = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Ingrese su clave: ");
                    clave = Convert.ToInt64(Console.ReadLine());
                    if (username == 40234533160 && clave == 123456)
                    {
                        Console.WriteLine("\nEstas dentro!");
                        Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username, rol, estado1);
                    }
                    
                    
                    else if (username == 40231233160 && clave == 654321)
                    {
                        Console.WriteLine("\nEstas dentro!");
                        Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username2, rol2, estado1);
                    }
                    
                    else if (username == 40231233160 && clave == 987654)
                    {
                        Console.WriteLine("\nEstas dentro!");
                        Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username3, rol3, estado1);
                    }

                    else
                    {
                        while (username != 40234533160 && clave != 123456 || username2 != 40231233160 &&
                                clave2 != 654321 || username3 != 40231233160 && clave3 != 987654)
                        {
                            Console.WriteLine("\nError a ingresado un dato incorrecto");
                            Console.WriteLine("Inicio de sesion");
                            Console.Write("Ingrese su Usuario: ");
                            username = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Ingrese su clave: ");
                            clave = Convert.ToInt64(Console.ReadLine());

                            if (username == 40234533160 && clave == 123456)
                            {
                                Console.WriteLine("\nEstas dentro!");
                                Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username, rol, estado1);                            }

                            else if (username2 == 40231233160 && clave2 == 654321)
                            {
                                Console.WriteLine("\nEstas dentro!");
                                Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username2, rol2, estado1);                            }

                            else if (username3 == 40231233160 && clave3 == 987654)
                            {
                                Console.WriteLine("\nEstas dentro!");
                                Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username3, rol3, estado1);
                            }

                            else
                            {
                                Console.WriteLine("Hubo un error");
                            }
                        }
                    }
                }

                else // el else del else if
                {
                    System.Console.WriteLine("Pase buen dia!");
                }
            }

            else // el else del primer if
            {
                Console.WriteLine("ha elegido un caracter no existente \npruebe con otro");
                while (acceso > 2)
                {
                    Console.WriteLine("Que Accion usted desea tomar:? ");
                    Console.Write("\n 1- Iniciar sesion \n 2- ver registros de Activos o Inactivos \n >");
                    acceso = Convert.ToInt32(Console.ReadLine());
                    if (acceso == 1)
                    {
                            Console.WriteLine("\nIniciar Sesion");
                            Console.Write("Ingrese su Usuario: ");
                            username = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Ingrese su clave: ");
                            clave = Convert.ToInt64(Console.ReadLine());
                            if (username == 40234533160 && clave == 123456)
                            {
                                Console.WriteLine("\nEstas dentro!");
                                Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username, rol, estado1);
                            }
                            
                            
                            else if (username == 40231233160 && clave == 654321)
                            {
                                Console.WriteLine("\nEstas dentro!");
                                Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username2, rol2, estado2);
                            }
                            
                            else if (username == 40231233160 && clave == 987654)
                            {
                                Console.WriteLine("\nEstas dentro!");
                                Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username3, rol3, estado1);
                            }

                            else
                            {
                                while (username != 40234533160 && clave != 123456 || username2 != 40231233160 &&
                                        clave2 != 654321 || username3 != 40231233160 && clave3 != 987654)
                                {
                                    Console.WriteLine("\nError a ingresado un dato incorrecto");
                                    Console.WriteLine("Inicio de sesion");
                                    Console.Write("Ingrese su Usuario: ");
                                    username = Convert.ToInt64(Console.ReadLine());
                                    Console.Write("Ingrese su clave: ");
                                    clave = Convert.ToInt64(Console.ReadLine());
                                    if (username == 40234533160 && clave == 123456)
                                    {
                                        Console.WriteLine("\nEstas dentro!");
                                        Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username, rol, estado1);                            }

                                    else if (username2 == 40231233160 && clave2 == 654321)
                                    {
                                        Console.WriteLine("\nEstas dentro!");
                                        Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username2, rol2, estado1);                            }

                                    else if (username3 == 40231233160 && clave3 == 987654)
                                    {
                                        Console.WriteLine("\nEstas dentro!");
                                        Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username3, rol3, estado1);
                                    }

                                    else
                                    {
                                        Console.WriteLine("Hubo un error");
                                    }
                                }
                            }
                    }

                    else if (acceso == 2)
                    {
                        Console.WriteLine("El usuario {0}, su rol {1} y su estado es {2}", username, rol, estado1);
                        Console.WriteLine("El usuario {0}, su rol {1} y su estado es {2}", username2, rol2, estado2);
                        Console.WriteLine("El usuario {0}, su rol {1} y su estado es {2}", username3, rol3, estado1);
                        Console.Write("Desea activar todos los inactivo si/no?: ");
                        string confi = Console.ReadLine();
                        if (confi == "si")
                        {
                            Console.WriteLine("\nYA ESTA ACTIVADO!!!");
                            Console.WriteLine("GRACIAS!!!");
                            Console.WriteLine("El usuario {0}, su rol {1} y su estado es {2}", username, rol, estado1);
                            Console.WriteLine("El usuario {0}, su rol {1} y su estado es {2}", username2, rol2, estado1);
                            Console.WriteLine("El usuario {0}, su rol {1} y su estado es {2}", username3, rol3, estado1);
                            Console.WriteLine("\nIniciar Sesion");
                            Console.Write("Ingrese su Usuario: ");
                            username = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Ingrese su clave: ");
                            clave = Convert.ToInt64(Console.ReadLine());
                            if (username == 40234533160 && clave == 123456)
                            {
                                Console.WriteLine("\nEstas dentro!");
                                Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username, rol, estado1);
                            }
                            
                            
                            else if (username == 40231233160 && clave == 654321)
                            {
                                Console.WriteLine("\nEstas dentro!");
                                Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username2, rol2, estado1);
                            }
                            
                            else if (username == 40231233160 && clave == 987654)
                            {
                                Console.WriteLine("\nEstas dentro!");
                                Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username3, rol3, estado1);
                            }

                            else
                            {
                                while (username != 40234533160 && clave != 123456 || username2 != 40231233160 &&
                                        clave2 != 654321 || username3 != 40231233160 && clave3 != 987654)
                                {
                                    Console.WriteLine("\nError a ingresado un dato incorrecto");
                                    Console.WriteLine("Inicio de sesion");
                                    Console.Write("Ingrese su Usuario: ");
                                    username = Convert.ToInt64(Console.ReadLine());
                                    Console.Write("Ingrese su clave: ");
                                    clave = Convert.ToInt64(Console.ReadLine());

                                    if (username == 40234533160 && clave == 123456)
                                    {
                                        Console.WriteLine("\nEstas dentro!");
                                        Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username, rol, estado1);                            }

                                    else if (username2 == 40231233160 && clave2 == 654321)
                                    {
                                        Console.WriteLine("\nEstas dentro!");
                                        Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username2, rol2, estado1);                            }

                                    else if (username3 == 40231233160 && clave3 == 987654)
                                    {
                                        Console.WriteLine("\nEstas dentro!");
                                        Console.WriteLine("Acabas de ingresar como {0}, su rol es {1} y su Estado es {2}", username3, rol3, estado1);
                                    }

                                    else
                                    {
                                        Console.WriteLine("Hubo un error");
                                    }
                                }
                            }
                        }

                        else // el else del else if
                        {
                            System.Console.WriteLine("Pase buen dia!");
                        }
                    }
                }
            }
        }
    }
}

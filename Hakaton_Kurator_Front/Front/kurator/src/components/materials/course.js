"use client"



const Course = () => {
    return (
        <div className={"border-solid border-2 border-text-inherit col-span-1 p-6"}>
            <h3 className={"text-4xl  mb-5"}>Название курса</h3>
            <div className={"flex text-2xl mb-5"}>
                <p className={"mr-2 text-gray-400"}>Рейтинг: ***** </p><span> 4.49</span>
            </div>
            <div className={"flex text-2xl mb-5"}>
                <p className={"mr-2 text-gray-400"}>Кол-во просмотров </p><span className={"after:content-['👁'] after:text-4xl after:text-sky-500"}> 228</span>
            </div>
            <div className={"flex text-2xl mb-5"}>
                <p className={"mr-2 text-gray-400"}>Дата загразки </p><span> 31.05.2024</span>
            </div>
        </div>

    )
}


export default Course
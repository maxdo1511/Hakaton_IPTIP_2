"use client"

const Event = () => {
    return (
        <div className={"border-solid border-2 border-text-inherit col-span-1 p-6 mt-10"}>
            <h3 className={"text-4xl  mb-5"}>Заголовок</h3>
            <p className={"text-2xl"}>Описание Описание Описание Описание Описание Описание Описание Описание Описание Описание Описание Описание Описание  Описание Описание Описание Описание Описание Описание </p>
            <div className={"flex justify-between"}>
                <div className={""}>
                    <span className={"text-2xl mr-10"}>15.09.2023</span>
                    <span className={"text-2xl mr-10 before:content-['★'] before:text-sky-500"}>4.5</span>
                    <span className={"text-2xl after:content-['👁'] after:text-4xl after:text-sky-500"}>228</span>
                </div>
                <span className={"text-blue-600 text-3xl font-bold"}>Подробнее..</span>
            </div>
        </div>

    )
}


export default Event